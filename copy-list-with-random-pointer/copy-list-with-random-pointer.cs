/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/
​
public class Solution {
    public Node CopyRandomList(Node head) {
        if(head == null)
    {
        return null;
    }
​
    Node current = head;
    Node next = current.next;
​
    // Insert copy nodes between
    // 1 -> 1' -> 2 -> 2' -> NULL
    while(current != null)
    {
        next = current.next;
​
        Node copy = new Node(current.val);
        current.next = copy;
        copy.next = next;
​
        current = next;
    }
​
    // Assign Random Pointers
    current = head;
    while(current != null)
    {
        if(current.random != null)
        {
            current.next.random = current.random.next;
        }
​
        current = current.next.next;
    }            
​
    // Extract Copy Nodes
    current = head;
    Node copyHead = new Node(0);
    Node currentCopy = copyHead;
​
    while(current != null)
    {
        next = current.next.next;
​
        currentCopy.next = current.next;
        currentCopy = currentCopy.next;
​
        current.next = next;
        current = current.next;
    }
​
    return copyHead.next;      
        
    }
}
