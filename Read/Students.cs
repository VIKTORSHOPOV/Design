namespace Read
{
    internal class Students
    {
        string name;
        string did;
        string adress;
        string klas;
        double dbel;
        double dforeign;
        double dmath;
        double dfizika;
        double dhimiq;
        double dbio;
        public string id { get { return did; } set { did = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Adress { get { return adress; } set { adress = value; } }
        public double Dbel { get { return dbel; } set { dbel = value; } }
        public double Dforeign { get { return dforeign; } set { dforeign = value; } }
        public double Dmath { get { return dmath; } set { dmath = value; } }
        public double Dfizika { get { return dfizika; } set { dfizika = value; } }
        public double Dhimiq { get { return dhimiq; } set { dhimiq = value; } }
        public double Dbio { get { return dbio; } set { dbio = value; } }
        public string clas { get { return clas; } set { clas = value; } }

        public double Average()
        {
            return Dbel + Dforeign + Dmath + Dhimiq + Dfizika + Dbio / 6;
        }


    }
}