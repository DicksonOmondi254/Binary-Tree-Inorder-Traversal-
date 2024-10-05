/++
* Definition for a binary tree node.
* public class TreeNode {
*     public class in val;
*     public TreeNode left;
*     public TreeNode right;
*     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
*       this. val = val;
*       this. left = left;
*       this. right = right;
*    }
* }
*/
public class solution {
    public Ilist<int> InorderTraversal(TreeNode) {
        Ilist<int> result=new list<int>();

        TreeNode currentNode=root;

        if(currentNode!=null){
            foreach(int r in InorderTraversal(currentNode.left))
            result .Add(r);
            result .Add(currentNode. val);
            foreach(int r in InorderTraversal(currentNode.right))
            result .Add(r);
        }

        return result;
    }
}