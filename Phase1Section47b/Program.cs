// See https://aka.ms/new-console-template for more information

using Phase1Section47b;

RunApp();

async voide RunApp(){
    SingleLinkedStringList list = new SingleLinkedStringList();
    StringNode node = new StringNode();
    node.Data = "Root";
    list.Add(node);

    for(int i = 0; i< 10; i++){
        StringNode newNode = new StringNode(i.ToString());
        list.Add(newNode);
    }
}