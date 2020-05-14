/*Implement counter using singleton (just use keyword “object”).
And create functions to:
○ get current value
○ increment the counter
The value of the property should be private.
In main function increment the counter and print current value.*/

object Singleton{
    init{
        println("singleton works now!")
    }
    var counter = 0
    fun getCurrentValue(){
        println(counter)
    }
    fun incrementCounter(){
        counter++
    }
}


fun main(){ 
    Singleton.getCurrentValue()
    Singleton.incrementCounter()
    Singleton.getCurrentValue()
    Singleton.counter = 1
}
