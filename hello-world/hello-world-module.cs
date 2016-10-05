namespace hello_world
{
    public class hello_world_module
    {
        public string SayHello(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
              return "Name cannot be empty!!";
            }

            return string.Format("Hello {0}!", name);

                  }
    }
}
