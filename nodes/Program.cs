// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
node<int> list = linkedList(20);
list.printNodes();

node<int> linkedList(int numofElms){
	node<int> root = new(0);
	node<int> tail = root;
	for( int i = 1 ; i < numofElms ; i++){
	    tail.next.Add(new node<int>(i));
	    tail = tail.next[0];
	}
	return root;
}


class node<T>{
    
    public List<node<T>> next = new ();
    public T? value;
    
    public node(T val){ value = val; }

    public int hasnext(){ return next.Count; } 

	public void printNodes(){
		List<node<T>> queue = new();
		Console.WriteLine(value);
		next.ForEach( n => queue.Add(n));
		queue.ForEach( n => n.printNodes());

	}

}

