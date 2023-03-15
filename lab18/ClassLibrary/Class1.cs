namespace ClassLibrary
{
    public class Triangle
    {
        public int sidea;
        public int sideb;
        public int sidec;

        public Triangle(int sideA, int sideB, int sideC)
        {
            this.sidea = sideA;
            this.sideb = sideB;
            this.sidec = sideC;
        }

        public bool allSidesChecker()
        {
            if (sidea == null)
            {
                return false;
            }
            else if (sideb == null)
            {
                return false;
            }
            else if (sidec == null)
            {
                return false;
            }
            return true;
        }

        public int PerimetrOfTriangle(int sideA, int sideB, int sideC)
        {
            return sideA + sideB + sideC;
        }

        public double SquareOfTriangle(int sideA, int sideB, int sideC)
        {
            double perimetr = Convert.ToDouble(PerimetrOfTriangle(sideA, sideB, sideC));
            double square = Convert.ToDouble(Math.Sqrt(perimetr * (perimetr - sideA) * (perimetr - sideB) * (perimetr - sideC)));
            return square;
        }

        public string TypeOfTriangle(int sideA, int sideB, int sideC)
        {
            string triangleType = "";
            if (sideA != sideB && sideA != sideC && sideB != sideC)
            {
                triangleType = "разносторонний";
            }
            else if (sideA == sideB && sideA == sideC)
            {
                triangleType = "равносторонний";
            }
            else if (sideA == sideB || sideA == sideC || sideB == sideC)
            {
                triangleType = "равнобердренный";
            }
            return triangleType;
        }
    }

    public class Rectangle
    {
        public int sidelength;
        public int sidewidth;


        public Rectangle(int sideLength, int sideWidth)
        {
            this.sidelength = sideLength;
            this.sidewidth = sideWidth;
        }

        public int PerimetrOfRectangle(int sideLength, int sideWidth)
        {
            return (sideLength + sideWidth) * 2;
        }
        public int SquareOfRectangle(int sideLength, int sideWidth)
        {
            return sideLength * sideWidth;
        }
    }

    public class CarsPark
    {
        public string carname;
        public string yearofrelease;
        public double enginecapacity;
        public decimal carprice;
        public bool isonparking;

        public CarsPark(string carName, string yearOfRelease, double engineCapacity, decimal carPrice, bool isOnParking)
        {
            this.carname = carName;
            this.yearofrelease = yearOfRelease;
            this.enginecapacity = engineCapacity;
            this.carprice = carPrice;
            this.isonparking = isOnParking;
        }

        public bool CheckParking(bool isOnParking)
        {
            if (!isOnParking)
            {
                return false;
            }
            return true;
        }

        public void AddToParking()
        {
            isonparking = true;
        }

        public void RemoveFromParking()
        {
            isonparking = false;
        }

    }
}