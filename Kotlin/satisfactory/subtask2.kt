// Implement enum class named "DAYS" which provide names of the weekdays
// and use companion object to check if the day is a weekend
// Tips:
// - provide boolean values for Enum constants
// - create companion object and function inside to check if variable "today" belong to the weekend
// available under the followning link: https://pl.kotl.in/FjF30WUYN

enum class DAYS(val isWeekend: Boolean){
    MONDAY(false),
    TUESDAY(false),
    WEDNESDAY(false),
	THURSDAY(false),
	FRIDAY(false),
    SATURDAY(true),
    SUNDAY(true);
    
    companion object {
          fun checkDay(obj: DAYS): Boolean{
              if(obj.name == "SATURDAY" || obj.name == "SUNDAY"){
                  return true
              }
              else{
                  return false
              }
          }
    }
}


fun main(){ 
    for(day in DAYS.values()) { 
        println("${day.ordinal} = ${day.name} and is weekend ${day.isWeekend}") 
    } 

    val today = DAYS.WEDNESDAY; 
    println("Is today a weekend ${DAYS.checkDay(today)}") 
}
