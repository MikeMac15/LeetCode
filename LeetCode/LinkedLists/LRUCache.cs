public class LRUCache {
    Dictionary<int,LinkedListNode<KeyValuePair<int,int>>> cache;
    LinkedList<KeyValuePair<int,int>> list;
    int maxCap;
    public LRUCache(int capacity) {
        this.cache = new Dictionary<int,LinkedListNode<KeyValuePair<int,int>>>();
        this.list = new LinkedList<KeyValuePair<int,int>>();
        this.maxCap = capacity;
    }
    
    public int Get(int key) {
        if( this.cache.TryGetValue(key, out LinkedListNode<KeyValuePair<int,int>> node)){
            this.list.Remove(node);
            this.list.AddFirst(node);
            return node.Value.Value;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        if (this.cache.TryGetValue(key, out LinkedListNode<KeyValuePair<int,int>> node)) {
            node.Value = new KeyValuePair<int,int>(key,value);
            this.list.Remove(node);
            this.list.AddFirst(node);
        } else {

        if (this.list.Count == this.maxCap){
            LinkedListNode<KeyValuePair<int,int>> last = this.list.Last;
            this.cache.Remove(last.Value.Key);
            this.list.RemoveLast();
        }
            LinkedListNode<KeyValuePair<int,int>> newNode = new LinkedListNode<KeyValuePair<int,int>>(new KeyValuePair<int,int>(key,value));
            this.list.AddFirst(newNode);
            this.cache[key] = newNode;
        }
    }
}