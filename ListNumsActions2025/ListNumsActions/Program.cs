namespace ListNumsActions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command.ToLower() == "finish")
                {
                    break;
                }
                switch (command)
                {
                    case "ins": int index= int.Parse(cmd[1]);
                        int num = int.Parse(cmd[2]);
                        nums.Insert(index,num);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", nums));
                        break;
                    case "contains":
<<<<<<< HEAD
                        //Kzl
=======
                        // KZL
>>>>>>> f8df6897cc8203ab3667f034269a19581fbcb9f8
                        int cont= int.Parse(cmd[3]); 
                        if (cont >= 1)
                        {
                            Console.WriteLine( "Yes" );
                        }

                        else
                        {
                            Console.WriteLine("No");
                        }
                        
                        //TODO
                        break;

                    case "remove":
                        int indexs = int.Parse(cmd[1]);
                        nums.Remove(indexs);
                        break;


                    //TO DO
                    default:
                        break;
                }
            }
        }
    }
}
