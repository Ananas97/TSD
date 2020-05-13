/**
 * Available under: 
 * https://pl.kotl.in/TVBQNkEz8
 */
open class Vehicle(doorsCount: Int, wheelsCount: Int, type: String){
  var type: String
  var horsePower: Int? = null
  var doorsCount: Int
  var wheelsCount: Int
  var fuelType: String = "Petrol"
    
  init{ 
      this.doorsCount = doorsCount
      this.wheelsCount = wheelsCount
      this.type = type
  }  
  constructor(doorsCount: Int, wheelsCount: Int, type: String, horsePower: Int) : this(doorsCount, wheelsCount, type){
      this.horsePower = horsePower
  }
  
    constructor(doorsCount: Int, wheelsCount: Int, type: String, horsePower: Int, fuelType: String) : this(doorsCount, wheelsCount, type, horsePower){
      this.fuelType = fuelType
  }
  
  open fun drive(){
      println("Vehicle drives")
  }
  
}
class Truck: Vehicle{
    constructor(doorsCount: Int, wheelsCount: Int, type: String): super(doorsCount, wheelsCount, type)
    
    override fun drive(){
        println("Truck drives")
    }
}

fun main() {
    var vehicle = Vehicle(2,6,"Car",110,"LPG")
    vehicle.drive()
    var truck = Truck(2,6,"Concrete Mixer")
    truck.drive()
}
