using System;
namespace Tsts
{
    public class HomeTask
    {
        private double wrk;
        public HomeTask(double wrk)
        {
            this.wrk = wrk;
        }
        
        public double GetWrk()
        {
            return wrk;
        }
        public void IncreasePrice(double count)
            => wrk *= count;

        public void AddWrk(double count)
            => wrk += count;
        
        public void ShareWrk(double count)
            => price /= count;

        public void SubtractNumFromWrk(double count)
            => price -= count;
    }
}