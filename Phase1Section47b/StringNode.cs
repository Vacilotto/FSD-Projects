namespace Phase1Section47b{
    internal class StringNode{
        internal string Data{get;set;}

        internal StringNode Next {get; set;}

        internal StringNode Previous {get;set;}

        internal StringNode(){
            
        }

        internal StringNode(string s){
            Data = s;
        }
    }
}