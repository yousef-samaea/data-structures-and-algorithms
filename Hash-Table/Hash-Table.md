# Hash Table

The Hashtable is a non-generic collection that stores key-value pairs, similar to generic Dictionary<TKey, TValue> collection. It optimizes lookups by computing the hash code of each key and stores it in a different bucket internally and then matches the hash code of the specified key at the time of accessing values.

### problem domain :

i needs to make a Hash Table that haves a set and get and contain keys anf hash methods.

### Approach & Efficiency
###  BIG O
          Time	    Space
Sit	      O(n)  	O(1)
Get	      O(n)      O(1)
Contains  O(n)	    O(1)
Hash	  O(n)  	O(1)

### Edge case :

integer key



### API
this challinge methods :

1. Set: takes  the key and value as argoments and it should hash the key, and add the key and value pair to the table, handling 2.collisions as needed.
2. Get: takes key as argoment then returns the value from the Hash Table.
3. Contains: takes the key as argoment then returns true or false, indicating if the key exists in the table or not.
4. Hash: takes in an arbitrary key and returns an index in the collection.

