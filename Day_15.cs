

	public static  Node insert(Node head,int data)
	{
      //Complete this method
        Node newnode = new Node(data);
            Node currentnode;
            if (head == null)
                head = newnode;
            else
            {
                currentnode = head;
                while (currentnode.next != null)
                {
                       currentnode = currentnode.next;
                }
                currentnode.next = newnode;
            }

            return head;
          
    }

