namespace zad6
{
    /// <summary>
    /// Created class Listener
    /// </summary>

    internal class Listener
    {
        private string _name;

        public Listener(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Created method of subscriber to "listen" event
        /// </summary>
        /// <param name="message"></param>

        public void Listen(string message)
        {
            Console.WriteLine($"{_name} see: {message}");
        }
    }
}