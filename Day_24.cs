

  public static Node removeDuplicates(Node head)
  {
    //Write your code here
            if (head == null)
                return head;
            else
            {
                Node currentnode = head;
                Node prevnode = null;
                //Console.WriteLine("Inside");
                while (currentnode != null)
                {
                  //  Console.WriteLine(currentnode.data);
                    if (prevnode is not null)
                    {
                        if (prevnode.data == currentnode.data)
                        {
                            prevnode.next = currentnode.next;
                            currentnode = currentnode.next;
                        }
                        else
                        {
                            prevnode = currentnode;
                            currentnode = currentnode.next;
                        }

                    }
                    else
                    {
                        prevnode = currentnode;
                        currentnode = currentnode.next;
                    }
             
                    
                    

                }
            }
                return head;
  }

