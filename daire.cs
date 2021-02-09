using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Generics
{

    public static class Program 
    {
        public static void Main(string[] args) 
        {
           Dictionary<string> daireler1 = new Dictionary<string>();
           daire.Add("daireler1","mollaoğlu");
           daire.Add("daireler1","mollaoğlu");
           daire.Add("daireler1","mollaoğlu");

           foreach (var item in daireler1)
           {
           	Console.WriteLine(item);
           }
           
           MyDictionary<string> daireler2 = new MyDictionary<string>();
           daireler2.Add("daireler2", "inci");
           daireler2.Add("daireler2", "inci");
           daireler2.Add("daireler2", "inci");
           
         
        }
    }
    
    class MyDictionary<TKey, TValue>
    {
    	TKey[] _key;
    	TKey[] _tempKey;
    	
    	TValue[] _value;
    	TValue[] _tempValue;
    	
    	public MyDictionary()
    	{
    		_key = new TKey[0];
    		_value = new TValue[0];
    	}
    	
    	public void Add(TKey key, TValue)
    	{
    		_tempKey = _key;
    		_tempValue = _value;
    		
    		_key = new TKey[_key.Lenght + 1];
    		_value = new TValue[_value.Length + 1];
    		
    		for (int i=0; i<_tempArray.Length; i++)
    		{
    			_key[i] = _tempKey[i];
    			_value[i] = _tempValue[i];
    		}
    		
    		_key[_key.Length - 1] = item;
    	}
    
    	
    	public int Count
    	{
    		get ( return _key.Length; )
    	}
    	
    }
    
}