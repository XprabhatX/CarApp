namespace CarApp
{
    public class CarRepository
    {
        CarContext context = new CarContext();

        public bool AddCar(Car car)
        {
            context.Cars.Add(car);
            int result = context.SaveChanges();
            return result > 0;
        }

        public Car GetCar(int id)
        {
            Car desiredCar = context.Cars.Find(id);
            return desiredCar;
        }

        public List<Car> GetAllCars()
        {
            return context.Cars.ToList();
        }

        public bool UpdateCarPrice(int id, double price)
        {
            Car desiredCar = context.Cars.Find(id);
            if (desiredCar != null)
            {
                desiredCar.Price = price;
                int result = context.SaveChanges();
                return result > 0;
            }
            return false;
        }

        public bool RemoveCar(int id)
        {
            Car desiredCar = context.Cars.Find(id);
            if (desiredCar != null)
            {
                context.Remove(desiredCar);
                int result = context.SaveChanges();
                return result > 0;
            }
            return false;
        }
    }
}