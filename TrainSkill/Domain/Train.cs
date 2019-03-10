namespace TrainSkill.Domain
{
    public class Train : ITrain
    {
        int status;
        int delta;

        public Train(int status, int delta)
        {
            this.status = status;
            this.delta = delta;
        }

        public bool IsDelayed => status == 2;

        public int DelayInMinutes => delta / 60;
    }
}
