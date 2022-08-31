namespace CarManufacturer
{
    internal class Car
    {
        private string v1;
        private string v2;
        private int v3;
        private int v4;
        private int v5;
        private Engine engine;
        private StartUp.Tire[] tires;

        public Car(string v1, string v2, int v3, int v4, int v5, Engine engine, StartUp.Tire[] tires)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.engine = engine;
            this.tires = tires;
        }
    }
}