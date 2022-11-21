

	static void levelOrder(Node root){
  		//Write your code here
                 Queue<Node> queue = new Queue<Node>();
            if (root != null)
            {
                queue.Enqueue(root);
                while (queue.Count > 0)
                {
                    Node currentnode = queue.Dequeue();
                     Console.Write("{0} ",currentnode.data);
                    if (currentnode.left != null) 
                        queue.Enqueue(currentnode.left) ;
                    if (currentnode.right != null)
                        queue.Enqueue (currentnode.right) ;
                }
            }
     
    }

