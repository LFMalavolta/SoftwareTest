namespace TS.Classes
{
    public class Meses
    {
        public bool validaMes(int mes)
        {
            if (mes <= 0 || mes > 12)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validaMes30Dias(int dia)
        {
            if (dia != 30)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
