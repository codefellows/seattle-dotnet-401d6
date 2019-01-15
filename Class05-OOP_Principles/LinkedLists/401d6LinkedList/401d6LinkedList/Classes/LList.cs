namespace _401d6LinkedList.Classes
{
    class LList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        //public LList(Node node)
        //{
        //    Head = node;
        //}

        public void Insert(int value)
        {
            Node silly = new Node(value);
            silly.Next = Head;
            Head = silly;
        }

        public bool Includes(int value)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    return true;
                }
                Current = Current.Next;
            }
            if (Current.Value == value)
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            if(Head != null)
            {
                Current = Head;

                while (Current.Next != null)
                {
                    System.Console.Write($"{Current.Value} => ");
                    Current = Current.Next;
                }

                System.Console.WriteLine($"{Current.Value} => Null");
            }
            else
            {
                System.Console.WriteLine("Your LL is empty");
            }


        }

        public void Append(int value)
        {
            while (Current.Next != null)
            {
                Current = Current.Next;
            }

            Node node = new Node(value);

            Current.Next = node;

        }

        public void InsertBefore(int value, int newValue)
        {
            Current = Head;

            if (Current.Value == value)
            {
                Insert(newValue);
                return;
            }


            while (Current.Next != null )
            {
                if (Current.Next.Value == value)
                {
                    Node node = new Node(newValue);
                    node.Next = Current.Next;
                    Current.Next = node;
                    return;
                }

                Current = Current.Next;
            }
        }


    }
}
