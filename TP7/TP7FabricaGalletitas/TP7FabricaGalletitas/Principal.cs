using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP7FabricaGalletitas
{
    public partial class Principal : Form
    {
        //Servidores y Eventos del Sistema
        private LlegadaCamion llegadaCamion;
        private ColaDescarga colaDescarga;
        private ColaAbastecimiento colaAbasteciemiento;
        private TuboAspirador tuboAspirador;

        private FinDescarga finDescargaSilo1, finDescargaSilo2, finDescargaSilo3, finDescargaSilo4;
        private FinAbastecimiento finAbastecimientoSilo1, finAbastecimientoSilo2, finAbastecimientoSilo3, finAbastecimientoSilo4;
        private Silo silo1, silo2, silo3, silo4;

        //Parametros de la corrida
        private double tiempoFinCorrida;
        private double filaAPartirDeDondeMostrar, filaHastaDondeMostrar;
        private int llegCamionA, llegCamionB;
        private double probTipoCamion, tasaAbastecimientoPlanta;
        private int capacidadSilo;
        private int tasaDescarga;
        private double h;

        //Variables necesarias
        private Reloj relojSimulacion;
        Random rand = new Random((int)DateTime.Now.Ticks);

        public Principal()
        {
            InitializeComponent();
            rnbEcDif.Checked = true;
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                SetLoading(true);

                this.tomarDatosPatalla();
                this.inicializarVariables();

                //Limpiar Grilla 
                dgvResultados.Rows.Clear();
                //Genero Evento Llegada Pedido 0
                llegadaCamion.simular(relojSimulacion, rand.NextDouble());

                //Imprimo fila 0
                if (this.filaAPartirDeDondeMostrar == 0 || radioCada10mil.Checked)
                {
                    this.dgvResultados.Rows.Add();
                    agregarEventoInicio();
                }

                //Bucle principal 
                simulacion();

                SetLoading(false);
            }
        }

        private void simulacion() {
            int fila = 0;
            while (relojSimulacion.getReloj() < tiempoFinCorrida)
            {
                //Selecciono el siguiente evento
                Reloj firstEvent = this.getFirstEvent(
                    this.llegadaCamion.getProximoTiempo(),
                    this.finDescargaSilo1.getProximoTiempo(),
                    this.finDescargaSilo2.getProximoTiempo(),
                    this.finDescargaSilo3.getProximoTiempo(),
                    this.finDescargaSilo4.getProximoTiempo(),
                    this.finAbastecimientoSilo1.getProximoTiempo(),
                    this.finAbastecimientoSilo2.getProximoTiempo(),
                    this.finAbastecimientoSilo3.getProximoTiempo(),
                    this.finAbastecimientoSilo4.getProximoTiempo());

                //Cargo el reloj y genero una nueva fila
                this.relojSimulacion.setReloj(firstEvent.getReloj());
                fila++;

                //Llegada camion
                if (this.llegadaCamion.getProximoTiempo().Equals(firstEvent))
                {
                    
                    this.llegadaCamion.simular(this.relojSimulacion, this.rand.NextDouble());

                    Silo siloLibre = getSiloLibre(this.silo1, this.silo2, this.silo3, this.silo4);

                    if (siloLibre != null)
                    {

                        if (this.silo1.getEstado() != Constantes.ESTADO_SILO_SIENDO_LLENADO &&
                     this.silo2.getEstado() != Constantes.ESTADO_SILO_SIENDO_LLENADO &&
                     this.silo3.getEstado() != Constantes.ESTADO_SILO_SIENDO_LLENADO &&
                     this.silo4.getEstado() != Constantes.ESTADO_SILO_SIENDO_LLENADO)
                        {

                            if ((siloLibre.getToneladasAcum() + llegadaCamion.getCamion().Toneladas) <= siloLibre.getCapacidadMax())
                            {
                                generarDemoraDescarga(fila, siloLibre.getId(), llegadaCamion.getCamion().Toneladas);
                            }
                            else
                            {

                                // EN EL CASO DE SOBREPASAR LA CAPACIDAD DEL SILO METE EN COLA AL CAMION CON LAS TONELADAS ACTUALIZADAS
                                // PARA PROXIMA DESCARGA
                                int toneladasSobrantes = getToneladasSobrantes(siloLibre, this.llegadaCamion);
                                llegadaCamion.getCamion().Toneladas = toneladasSobrantes;
                                ponerColaCamion(llegadaCamion); // siempre pone en cola porque aspira de uno a la vez

                                int acumT = getToneladasAcumuladas(siloLibre);
                                generarDemoraDescarga(fila, siloLibre.getId(), acumT);

                            }

                        }

                    }
                    else {
                        ponerColaCamion(llegadaCamion);
                    }

                    imprimirFila(llegadaCamion, fila);
                }
                else {
                    //Evento Fin Descarga S1
                    if (this.finDescargaSilo1.getProximoTiempo().Equals(firstEvent))
                    {
                        finDescargaSilo1.setHoraFin(new Reloj());

                        //actualizar el camion a descargado
                        cambiarEstadoCamion(llegadaCamion.getCamion());

                        //si hay cola sacar de colar y calcular nueva demora DESCARGA
                        this.silo1.setEstado(Constantes.ESTADO_SILO_LIBRE);
                        actualizarEstadoSilo(silo1, fila);

                        //genero FIN DE ABASTECIMIENTO
                        if(silosAbasteciendoPlanta() && this.silo1.getToneladasAcum() == this.silo1.getCapacidadMax())
                        {
                            ponerColaSilo(silo1); // PONE EN COLA EN ABASTECIMIENTO
                        }
                        else
                        {
                            if (this.silo1.getToneladasAcum() == this.silo1.getCapacidadMax())
                            {
                                generarDemoraAbastecimiento(1);
                            }
                        }

                        imprimirFila(finDescargaSilo1, fila);
                    }
                    //Evento Fin Descarga S2
                   else if (this.finDescargaSilo2.getProximoTiempo().Equals(firstEvent))
                    {
                        finDescargaSilo2.setHoraFin(new Reloj());

                        //actualizar el camion a descargado
                        cambiarEstadoCamion(llegadaCamion.getCamion());

                        //si hay cola sacar de colar y calcular nueva demora 
                        this.silo2.setEstado(Constantes.ESTADO_SILO_LIBRE);
                        actualizarEstadoSilo(silo2, fila);

                        if (silosAbasteciendoPlanta() && this.silo2.getToneladasAcum() == this.silo2.getCapacidadMax())
                        {
                            ponerColaSilo(silo2);
                        }
                        else
                        {
                            if (this.silo2.getToneladasAcum() == this.silo2.getCapacidadMax())
                            {
                                generarDemoraAbastecimiento(2);
                            }
                        }


                        imprimirFila(finDescargaSilo2, fila);
                    }
                    else if (this.finDescargaSilo3.getProximoTiempo().Equals(firstEvent))
                    {
                        finDescargaSilo3.setHoraFin(new Reloj());

                        //actualizar el camion a descargado
                        cambiarEstadoCamion(llegadaCamion.getCamion());

                        //si hay cola sacar de colar y calcular nueva demora 
                        this.silo3.setEstado(Constantes.ESTADO_SILO_LIBRE);
                        actualizarEstadoSilo(silo3, fila);

                        //UNA VEZ LLENADO EL TOTAL GENERA UNA DEMORA DE ABASTECIMIENTO
                        if (silosAbasteciendoPlanta() && this.silo3.getToneladasAcum() == this.silo3.getCapacidadMax())
                        {
                            ponerColaSilo(silo3);
                        }
                        else
                        {
                            if (this.silo3.getToneladasAcum() == this.silo3.getCapacidadMax()) {
                                generarDemoraAbastecimiento(3);
                            }
                           
                        }

                        imprimirFila(finDescargaSilo3, fila);
                    }
                    else if (this.finDescargaSilo4.getProximoTiempo().Equals(firstEvent))
                    {
                        finDescargaSilo4.setHoraFin(new Reloj());

                        //actualizar el camion a descargado
                        cambiarEstadoCamion(llegadaCamion.getCamion());

                        //si hay cola sacar de colar y calcular nueva demora 
                        this.silo4.setEstado(Constantes.ESTADO_SILO_LIBRE);
                        actualizarEstadoSilo(silo4, fila);

                        if (silosAbasteciendoPlanta() && this.silo4.getToneladasAcum() == this.silo4.getCapacidadMax())
                        {
                            ponerColaSilo(silo4);
                        }
                        else
                        {
                            if (this.silo4.getToneladasAcum() == this.silo4.getCapacidadMax())
                            {
                                generarDemoraAbastecimiento(4);
                            }
                        }

                        imprimirFila(finDescargaSilo4, fila);
                    }
                    //Evento Fin Abastecimiento S1
                    else if (this.finAbastecimientoSilo1.getProximoTiempo().Equals(firstEvent))
                    {
                        finAbastecimientoSilo1.setHoraFin(new Reloj());

                        finAbastecimientoSilo1.GetSilo().setToneladasAcum(0);
                        finAbastecimientoSilo1.GetSilo().setEstado(Constantes.ESTADO_SILO_LIBRE);
                        silo1.setEstado(Constantes.ESTADO_SILO_LIBRE);
                        silo1.setToneladasAcum(0);

                        if (colaAbasteciemiento.getCola().Count() != 0)
                        {
                            Silo silo = colaAbasteciemiento.getCola().Dequeue();
                            generarDemoraAbastecimiento(silo.getId());
                        }

                        imprimirFila(finAbastecimientoSilo1, fila);
                    }
                    //Evento Fin Abastecimiento S2
                    else if (this.finAbastecimientoSilo2.getProximoTiempo().Equals(firstEvent))
                    {
                        finAbastecimientoSilo2.setHoraFin(new Reloj());

                        finAbastecimientoSilo2.GetSilo().setToneladasAcum(0);
                        finAbastecimientoSilo2.GetSilo().setEstado(Constantes.ESTADO_SILO_LIBRE);
                        silo2.setEstado(Constantes.ESTADO_SILO_LIBRE);
                        silo2.setToneladasAcum(0);

                        if (colaAbasteciemiento.getCola().Count() != 0)
                        {
                            Silo silo = colaAbasteciemiento.getCola().Dequeue();
                            generarDemoraAbastecimiento(silo.getId());

                        }

                        imprimirFila(finAbastecimientoSilo2, fila);
                    }
                    //Evento Fin Abastecimiento S3
                    else if (this.finAbastecimientoSilo3.getProximoTiempo().Equals(firstEvent))
                    {
                        finAbastecimientoSilo3.setHoraFin(new Reloj());

                        finAbastecimientoSilo3.GetSilo().setToneladasAcum(0);
                        finAbastecimientoSilo3.GetSilo().setEstado(Constantes.ESTADO_SILO_LIBRE);
                        silo3.setEstado(Constantes.ESTADO_SILO_LIBRE);
                        silo3.setToneladasAcum(0);

                        if (colaAbasteciemiento.getCola().Count() != 0)
                        {
                            Silo silo = colaAbasteciemiento.getCola().Dequeue();

                            generarDemoraAbastecimiento(silo.getId());
                        }
   
                        imprimirFila(finAbastecimientoSilo3, fila);
                    }
                    //Evento Fin Abastecimiento S4
                    else if (this.finAbastecimientoSilo4.getProximoTiempo().Equals(firstEvent))
                    {
                        finAbastecimientoSilo4.setHoraFin(new Reloj());
                        finAbastecimientoSilo4.GetSilo().setToneladasAcum(0);
                        finAbastecimientoSilo4.GetSilo().setEstado(Constantes.ESTADO_SILO_LIBRE);
                        silo4.setEstado(Constantes.ESTADO_SILO_LIBRE);
                        silo4.setToneladasAcum(0);

                        if (colaAbasteciemiento.getCola().Count() != 0)
                        {
                            Silo silo = colaAbasteciemiento.getCola().Dequeue();
                            generarDemoraAbastecimiento(silo.getId());
                        }

                        imprimirFila(finAbastecimientoSilo4, fila);
                    }

                }
            }
        }

        private int getToneladasAcumuladas(Silo s) {
           
            return Math.Abs(s.getCapacidadMax() - s.getToneladasAcum());
        }

        private int getToneladasSobrantes(Silo s, LlegadaCamion lc)
        {
           return Math.Abs((s.getToneladasAcum() + lc.getCamion().Toneladas) - s.getCapacidadMax());
        }

        private bool silosAbasteciendoPlanta() {
            return this.silo1.getEstado() == Constantes.ESTADO_SILO_ABASTECIENDO ||
             this.silo2.getEstado() == Constantes.ESTADO_SILO_ABASTECIENDO ||
             this.silo3.getEstado() == Constantes.ESTADO_SILO_ABASTECIENDO ||
             this.silo4.getEstado() == Constantes.ESTADO_SILO_ABASTECIENDO;
          }

        private bool cambiarEstadoCamion(Camion camion)
        {
            return colaDescarga.cambiarEstadoCamion(camion);
        }


        private void ponerColaCamion(LlegadaCamion lc)
        {
            colaDescarga.setCola(lc.getCamion());
        }

        private void ponerColaSilo(Silo silo)
        {
            silo.setEstado("EnCola");
            colaAbasteciemiento.setCola(silo);
        }

        public void generarDemoraDescarga(int i, int id, int toneladas)
        {
            this.tuboAspirador.Estado = "Ocupado";
            double rnd = this.rand.NextDouble();
            switch (id)
            {
                case 1:
                    this.finDescargaSilo1.getSilo().setToneladasADescargar(toneladas);
                    int acums1 = this.finDescargaSilo1.getSilo().getToneladasAcum() + toneladas;
                    this.finDescargaSilo1.getSilo().setToneladasAcum(acums1);
                    this.finDescargaSilo1.simular(this.relojSimulacion, rnd);
                    break;
                case 2:
                    this.finDescargaSilo2.getSilo().setToneladasADescargar(toneladas);
                    int acums2 = this.finDescargaSilo2.getSilo().getToneladasAcum() + toneladas;
                    this.finDescargaSilo2.getSilo().setToneladasAcum(acums2);
                    this.finDescargaSilo2.simular(this.relojSimulacion, rnd);
                    break;
                case 3:
                    this.finDescargaSilo3.getSilo().setToneladasADescargar(toneladas);
                    int acums3 = this.finDescargaSilo3.getSilo().getToneladasAcum() + toneladas;
                    this.finDescargaSilo3.getSilo().setToneladasAcum(acums3);
                    this.finDescargaSilo3.simular(this.relojSimulacion, rnd);
                    break;
                case 4:
                    this.finDescargaSilo4.getSilo().setToneladasADescargar(toneladas);
                    int acums4 = this.finDescargaSilo4.getSilo().getToneladasAcum() + toneladas;
                    this.finDescargaSilo4.getSilo().setToneladasAcum(acums4);
                    this.finDescargaSilo4.simular(this.relojSimulacion, rnd);
                    break;
            }
        }

        public void generarDemoraAbastecimiento(int id)
        {
            double rnd = this.rand.NextDouble();
            switch (id)
            {
                case 1:  
                    this.finAbastecimientoSilo1.simular(this.relojSimulacion, rnd);
                    break;
                case 2:
                    this.finAbastecimientoSilo2.simular(this.relojSimulacion, rnd);
                    break;
                case 3:
                    this.finAbastecimientoSilo3.simular(this.relojSimulacion, rnd);
                    break;
                case 4:
                    this.finAbastecimientoSilo4.simular(this.relojSimulacion, rnd);
                    break;
            }
        }

        private void agregarEventoInicio()
        {
            dgvResultados.Rows[0].Cells["colFila"].Value = 0;
            dgvResultados.Rows[0].Cells["colEvento"].Value = Constantes.EVENTO_INICIO_SIM;
            dgvResultados.Rows[0].Cells["colReloj"].Value = relojSimulacion.getReloj();

            dgvResultados.Rows[0].Cells["colRndLlegadaCamion"].Value = llegadaCamion.getRandom();
            dgvResultados.Rows[0].Cells["colTiempoLlegadaCamion"].Value = llegadaCamion.getTiempoEntreLlegada();
            dgvResultados.Rows[0].Cells["colProxLlegadaCamion"].Value = llegadaCamion.getProximoTiempo().getReloj();

            dgvResultados.Rows[0].Cells["colColaCamion"].Value = "0";
            dgvResultados.Rows[0].Cells["colColaAbastecimiento"].Value = "0";
        }

        public void imprimirFila(Evento evento, int fila)
        {
            if ((fila >= this.filaAPartirDeDondeMostrar && fila <= filaHastaDondeMostrar)
                || radioCada10mil.Checked)
            {
                int i = this.dgvResultados.Rows.Add();
                agregarEventoAGrilla(i, evento, fila);
            }
        }

        private void agregarEventoAGrilla(int i, Evento evento, int fila) {

            Console.WriteLine("Imprimiendo: " + fila);

            //Columnas que se muestran siempre
            dgvResultados.Rows[i].Cells["colFila"].Value = fila;
            dgvResultados.Rows[i].Cells["colEvento"].Value = concatenarId(evento);
            dgvResultados.Rows[i].Cells["colReloj"].Value = relojSimulacion.getReloj();
            dgvResultados.Rows[i].Cells["colColaCamion"].Value = colaDescarga.getCola().Count();
            dgvResultados.Rows[i].Cells["colEstadoTuboAspirador"].Value = this.tuboAspirador.Estado;

            dgvResultados.Rows[i].Cells["colColaAbastecimiento"].Value = colaAbasteciemiento.getCola().Count();

            if (evento.getNombreEvento().Equals(Constantes.EVENTO_LLEGADA_CAMION)) {
                dgvResultados.Rows[i].Cells["colRndLlegadaCamion"].Value = llegadaCamion.getRandom();
                dgvResultados.Rows[i].Cells["colTiempoLlegadaCamion"].Value = llegadaCamion.getTiempoEntreLlegada();
                //dgvResultados.Rows[i].Cells["colProxLlegadaCamion"].Value = llegadaCamion.getProximoTiempo().getReloj();

                dgvResultados.Rows[i].Cells["colRndTipoCamion"].Value = llegadaCamion.getCamion().RndTipoCamion;
                dgvResultados.Rows[i].Cells["colTipoCamion"].Value = llegadaCamion.getCamion().Tipo;
            }

            dgvResultados.Rows[i].Cells["colProxLlegadaCamion"].Value = llegadaCamion.getProximoTiempo().getReloj();

            setColDemoraFinDescarga(finDescargaSilo1, 1, i);
            setColDemoraFinDescarga(finDescargaSilo2, 2, i);
            setColDemoraFinDescarga(finDescargaSilo3, 3, i);
            setColDemoraFinDescarga(finDescargaSilo4, 4, i);

            setColDemoraFinAbastecimiento(finAbastecimientoSilo1, 1, i);
            setColDemoraFinAbastecimiento(finAbastecimientoSilo2, 2, i);
            setColDemoraFinAbastecimiento(finAbastecimientoSilo3, 3, i);
            setColDemoraFinAbastecimiento(finAbastecimientoSilo4, 4, i);
        }

        private void setColDemoraFinDescarga(FinDescarga fd, int id, int i)
        {
            if (fd.getProximoTiempo().getReloj() > 0)
            {
                dgvResultados.Rows[i].Cells["colEstadoS" + id].Value = fd.getSilo().getEstado();
                dgvResultados.Rows[i].Cells["colToneladasAcumS" + id].Value = fd.getSilo().getToneladasAcum();

                dgvResultados.Rows[i].Cells["colToneladasADescargarS" + id].Value = fd.getSilo().getToneladasADescargar();
   
                
                dgvResultados.Rows[i].Cells["colDemoraS" + id].Value = fd.getTiempoEntreLlegada();
                dgvResultados.Rows[i].Cells["colFinDescargaS" + id].Value = fd.getProximoTiempo().getReloj();
            }else {
                dgvResultados.Rows[i].Cells["colEstadoS" + id].Value = fd.getSilo().getEstado();
                dgvResultados.Rows[i].Cells["colToneladasAcumS" + id].Value = fd.getSilo().getToneladasAcum();
            }
        }

        private void setColDemoraFinAbastecimiento(FinAbastecimiento fa, int id, int i)
        {
            if (fa.getProximoTiempo().getReloj() > 0)
            {
                dgvResultados.Rows[i].Cells["colDemoraAbastecimientoPlantaS"+id].Value = fa.getTiempoEntreLlegada();
                dgvResultados.Rows[i].Cells["colFinAbastecimientoPlantaS"+id].Value = fa.getProximoTiempo().getReloj();
            }
        }

        private void actualizarEstadoSilo(Silo s, int fila)
        {

            if (colaDescarga.getCola().Count != 0)
            {
                this.tuboAspirador.Estado = "Ocupado";
                Silo siloLibre = getSiloLibre(this.silo1, this.silo2, this.silo3, this.silo4);

                if (siloLibre != null)
                {

                    Camion camionEnCola = colaDescarga.getCola().Dequeue();
                    LlegadaCamion llc = new LlegadaCamion();
                    llc.setCamion(camionEnCola);
                    if ((siloLibre.getToneladasAcum() + llc.getCamion().Toneladas) <= siloLibre.getCapacidadMax())
                    {
                        generarDemoraDescarga(fila, siloLibre.getId(), llc.getCamion().Toneladas);
                    }
                    else
                    {
                        int toneladasSobrantes = getToneladasSobrantes(siloLibre, llc);
                        llc.getCamion().Toneladas = toneladasSobrantes;
                        ponerColaCamion(llc); // siempre pone en cola porque aspira de uno a la vez

                        int acumT = getToneladasAcumuladas(siloLibre);
                        generarDemoraDescarga(fila, siloLibre.getId(), acumT);

                    }

                }

            }
            else {
                this.tuboAspirador.Estado = "Libre";
                switch (s.getId())
                {
                    case 1:
                        silo1.setEstado(Constantes.ESTADO_SILO_LIBRE);
                        silo1.setDemora(0);
                        silo1.setFinDescarga(new Reloj());
                        break;
                    case 2:
                        silo2.setEstado(Constantes.ESTADO_SILO_LIBRE);
                        silo2.setDemora(0);
                        silo2.setFinDescarga(new Reloj());
                        break;
                    case 3:
                        silo3.setEstado(Constantes.ESTADO_SILO_LIBRE);
                        silo3.setDemora(0);
                        silo3.setFinDescarga(new Reloj());
                        break;
                    case 4:
                        silo4.setEstado(Constantes.ESTADO_SILO_LIBRE);
                        silo4.setDemora(0);
                        silo4.setFinDescarga(new Reloj());
                        break;
                }
            }

        }

        private void actualizaColaDescarga(Silo s, LlegadaCamion llc, int fila) {

            if ((s.getToneladasAcum() + llc.getCamion().Toneladas) <= s.getCapacidadMax())
            {
                generarDemoraDescarga(fila, s.getId(), llc.getCamion().Toneladas);
            }
            else
            {
                int toneladasSobrantes = getToneladasSobrantes(s, llc);
                int acumT = getToneladasAcumuladas(s);
                generarDemoraDescarga(fila, s.getId(), acumT);

                // EN EL CASO DE SOBREPASAR LA CAPACIDAD DLE SILO METE EN COLA AL CAMION CON LAS TONELADAS ACTUALIZADAS
                llc.getCamion().Toneladas = toneladasSobrantes;
                ponerColaCamion(llc);
            }

        }

        private void actualizarEstadoAbastecimiento(Silo s, int fila)
        {

            if (colaAbasteciemiento.getCola().Count != 0)
            {
                Silo silo = colaAbasteciemiento.getCola().Dequeue();
                Console.WriteLine("idsiloEncolado:" + silo.getId());
                //verificar estado del silo y generar
                generarDemoraAbastecimiento(silo.getId());
            }
            else
            {
                switch (s.getId())
                {
                    case 1:
                        silo1.setToneladasAcum(0);
                        silo1.setEstado(Constantes.ESTADO_SILO_LIBRE);
                        silo1.setDemora(0);
                        silo1.setFinDescarga(new Reloj());
                        break;
                    case 2:
                        silo1.setToneladasAcum(0);
                        silo2.setEstado(Constantes.ESTADO_SILO_LIBRE);
                        silo2.setDemora(0);
                        silo2.setFinDescarga(new Reloj());
                        break;
                    case 3:
                        silo3.setToneladasAcum(0);
                        silo3.setEstado(Constantes.ESTADO_SILO_LIBRE);
                        silo3.setDemora(0);
                        silo3.setFinDescarga(new Reloj());
                        break;
                    case 4:
                        silo4.setToneladasAcum(0);
                        silo4.setEstado(Constantes.ESTADO_SILO_LIBRE);
                        silo4.setDemora(0);
                        silo4.setFinDescarga(new Reloj());
                        break;
                }
            }

        }

        private string concatenarId(Evento e)
        {
            string idPedido = "";
            if (e.getNombreEvento() == Constantes.EVENTO_LLEGADA_CAMION)
            {
                idPedido = "-" + Convert.ToString(((LlegadaCamion)e).getCamion().Id);
            }
            return e.getNombreEvento() + idPedido;
        }

        private void rnbEcDif_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                btnVerEcDif.Enabled = rb.Checked;
                txtHDescarga.Enabled = rb.Checked;
                rnbTasaCte.Checked = !rb.Checked;
                txtTasaDescarga.Enabled = !rb.Checked;
            }
        }

        public Reloj getFirstEvent(Reloj n1, Reloj n2, Reloj n3, Reloj n4, Reloj n5, Reloj n6, Reloj n7, Reloj n8, Reloj n9)
        {
            List<Reloj> list = new List<Reloj>();
            if (n1.getReloj() > 0.0)
                list.Add(n1);
            if (n2.getReloj() > 0.0)
                list.Add(n2);
            if (n3.getReloj() > 0.0)
                list.Add(n3);
            if (n4.getReloj() > 0.0)
                list.Add(n4);
            if (n5.getReloj() > 0.0)
                list.Add(n5);
            if (n6.getReloj() > 0.0)
                list.Add(n6);
            if (n7.getReloj() > 0.0)
                list.Add(n7);
            if (n8.getReloj() > 0.0)
                list.Add(n8);
            if (n9.getReloj() > 0.0)
                list.Add(n9);
            list.Sort();
            return list.FirstOrDefault<Reloj>();
        }

        private Silo getSiloLibre(Silo s1, Silo s2, Silo s3, Silo s4) {
            List<Silo> list = new List<Silo>();
            list.Add(s1);
            list.Add(s2);
            list.Add(s3);
            list.Add(s4);

            var results = list.Where(s => s.getEstado() == Constantes.ESTADO_SILO_LIBRE && s.getToneladasAcum() < s.getCapacidadMax());
            return results.FirstOrDefault();
        }

        // VALIDACION
        private bool isValid()
        {
            return validarDatos() && esValidaProbabilidadTipoCamion() && esValidaLlegadaTipoCamion();
        }

        private bool validarDatos()
        {
            foreach (Control con in this.Controls)
            {
                if (con is GroupBox)
                {
                    if (validarGroup((GroupBox)con) ==  false) {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool validarGroup(GroupBox grupo)
        {
            foreach (Control con in grupo.Controls)
            {
                if (con is NumericUpDown)
                {
                    if (Validaciones.estaVacio((NumericUpDown)con))//Valida que los campos no esten vacios
                    {
                        MessageBox.Show("Parametros no pueden estar vacio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        con.Focus();
                        return false;
                    }
                }
            }

            return true;
        }

        private bool esValidaProbabilidadTipoCamion()
        {
            int tipoCamionA = Convert.ToInt32(txtTipoCamion10Tn.Value);
            int tipoCamionB = Convert.ToInt32(txtTipoCamion12Tn.Value);
            int total = tipoCamionA + tipoCamionB;
            if (total != 100)
            {
                MessageBox.Show("Parametros Incorrectos, la suma de ambos debe ser igual a 100%", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtTipoCamion10Tn.Focus();
                return false;
            }
            return true;
        }

        private bool esValidaLlegadaTipoCamion()
        {
            int tipoCamionA = Convert.ToInt32(txtLlegCamionA.Value);
            int tipoCamionB = Convert.ToInt32(txtLlegCamionB.Value);
            if (tipoCamionA > tipoCamionB)
            {
                MessageBox.Show("Parametros Incorrectos, A no puede ser mayor a B", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtLlegCamionA.Focus();
                return false;
            }
            return true;
        }

        // FIN VALIDACION


        public void tomarDatosPatalla()
        {
            this.tiempoFinCorrida = Convert.ToDouble(this.txtTiempoSim.Text);
            this.filaAPartirDeDondeMostrar = Convert.ToDouble(this.txtHsDesde.Text);
            this.filaHastaDondeMostrar = Convert.ToDouble(this.txtHsHasta.Text);
            this.llegCamionA = Convert.ToInt32(this.txtLlegCamionA.Value);
            this.llegCamionB = Convert.ToInt32(this.txtLlegCamionB.Value);
            this.capacidadSilo = Convert.ToInt32(this.txtCapacidadSilos.Value);
            this.tasaDescarga = Convert.ToInt32(this.txtTasaDescarga.Value);
            this.h = Convert.ToDouble(this.txtHDescarga.Value);
            this.probTipoCamion = Convert.ToDouble(this.txtTipoCamion10Tn.Value/100);
            this.tasaAbastecimientoPlanta = Convert.ToDouble(this.txtTasaAbastecimiento.Value);
        }

        public void inicializarVariables()
        {
            this.relojSimulacion = new Reloj();
            this.llegadaCamion = new LlegadaCamion(this.llegCamionA, this.llegCamionB, this.probTipoCamion);
            this.colaDescarga = new ColaDescarga();
            this.colaAbasteciemiento = new ColaAbastecimiento();
            this.tuboAspirador = new TuboAspirador();
            Camion.id = -1;

            //silos
            this.silo1 = new Silo(1, this.capacidadSilo);
            this.silo2 = new Silo(2, this.capacidadSilo);
            this.silo3 = new Silo(3, this.capacidadSilo);
            this.silo4 = new Silo(4, this.capacidadSilo);

            //finDescarga
            int tasaD = rnbEcDif.Checked ? 0 : this.tasaDescarga;
            this.finDescargaSilo1 = new FinDescarga(this.silo1, this.h, tasaD); // ver h y tasa descarga
            this.finDescargaSilo2 = new FinDescarga(this.silo2, this.h, tasaD);
            this.finDescargaSilo3 = new FinDescarga(this.silo3, this.h, tasaD);
            this.finDescargaSilo4 = new FinDescarga(this.silo4, this.h, tasaD);

            //finAbastecimiento
            this.finAbastecimientoSilo1 = new FinAbastecimiento(this.silo1, this.tasaAbastecimientoPlanta);
            this.finAbastecimientoSilo2 = new FinAbastecimiento(this.silo2, this.tasaAbastecimientoPlanta);
            this.finAbastecimientoSilo3 = new FinAbastecimiento(this.silo3, this.tasaAbastecimientoPlanta);
            this.finAbastecimientoSilo4 = new FinAbastecimiento(this.silo4, this.tasaAbastecimientoPlanta);

        }

        private void SetLoading(bool displayLoader)
        {
            if (displayLoader)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                });
            }
            else
            {
                this.Invoke((MethodInvoker)delegate
                {
                   this.Cursor = System.Windows.Forms.Cursors.Default;
                });
            }
        }

        private void btnVerEcDif_Click(object sender, EventArgs e)
        {
            EcDiferencial ecd = new EcDiferencial();
            ecd.Show();
        }

    }
}
