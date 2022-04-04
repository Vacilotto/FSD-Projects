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
            internal StringNode Next {get{return Current.Next;}}
            internal SingleLinkedStringList(){

            }

            internal void Add(StringNode node){
                    if(Root == null)
                        {
                            Root = node;
                            Length = 1;
                            Current = node;
                        }
                    else{
                        Current.Next = node;
                        Current = node;
                        Length++;
                }
            }

            internal void Add(string Data){
                StringNode node = new StringNode(s);
                if(Root == null)
                        {
                            Root = node;
                            Length = 1;
                            Current = node;
                        }
                    else{
                        Current.Next = node;
                        Current = node;
                        Length++;
                }
            }

            internal void GoToStart(){
                Current = Root;
            }
            internal void GoToNext(){
                Current = Next;
            }
        }
    
}