
namespace TP7Panaderia
{
    class Euler
    {

		public static double calEuler(double xi, double xderivada, double hciclo)
		{
			// xi+1=xi+h*derivada de xi
			return xi + (hciclo * xderivada);
		}

	}
}
