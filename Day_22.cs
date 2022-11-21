

	static int getHeight(Node root){
      //Write your code here
      if (root == null )
        return -1;
      else  
      {
                     // Console.WriteLine(root.data);
                      int leftheight = getHeight(root.left);
                      int rightheight = getHeight(root.right);
                  //return Math.Max(leftheight, rightheight) ;
                  if (leftheight > rightheight)
                      return leftheight +1;
                  else
                      return rightheight +1;
                    
      }
    }

