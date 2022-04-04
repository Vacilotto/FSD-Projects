using Phase1Section47b;

RunApp();
void RunApp(){
    SingleLinkedStringList list = new SingleLinkedStringList();
    StringNode node = new StringNode();
    node.Data = "Root";
    list.Add(node);

    for(int i = 0; i< 10; i++){
        StringNode newNode = new StringNode(i.ToString());
        list.Add(newNode);
    }
    System.Console.WriteLine($"Length of singly linked list = {list.Length}");
    StringNode nodeRef = list.Root;

    while(nodeRef!= null){
        System.Console.WriteLine(nodeRef.Data);
        nodeRef = nodeRef.Next;
    }
}