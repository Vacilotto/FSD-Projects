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
    internal class SingleLinkedStringList{

            internal StringNode Root{get; private set;}
            internal int Length {get; private set;}
            internal StringNode CurrentNode{get; private set;}
            internal StringNode Next {get{return CurrentNode.Next;}}
            internal SingleLinkedStringList(){

            }

            internal void Add(StringNode node){
                    if(Root == null)
                        {
                            Root = node;
                            Length = 1;
                            CurrentNode = node;
                        }
                    else{
                        CurrentNode.Next = node;
                        CurrentNode = node;
                        Length++;
                }
            }

            internal void Add(string Data){
                StringNode node = new StringNode(Data);
                if(Root == null)
                        {
                            Root = node;
                            Length = 1;
                            CurrentNode = node;
                        }
                    else{
                        CurrentNode.Next = node;
                        CurrentNode = node;
                        Length++;
                }
            }

            internal void GoToStart(){
                CurrentNode = Root;
            }
            internal void GoToNext(){
                CurrentNode = Next;
            }
        }
    
}