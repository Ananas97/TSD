// Rewrite the UglyTask in the sealed classes way.
// Tips - you should implement:
// - AssignedTo - sealed class
// - AssignedToNoOne - object (only inherit from AssignedTo())
// - AssignedToUser - data class (store User)
// - AssignedToGroup - data class (store Group)
// - and "when" block
// available: https://pl.kotl.in/SfurPVp6F

data class User(val name: String)
data class Group(val name: String)

class UglyTask(
        val name: String,
        val assignedUser: User? = null,
        val assignedGroup: Group? = null
) {

    init {
        if (assignedUser != null && assignedGroup != null) {
            throw IllegalArgumentException("a task can be assigned to either a user OR a group.")
        }
    }
}

fun UglyTask.printAssignment() {
    when {
        assignedGroup == null && assignedUser == null -> println("\"$name\" is assigned to no one")
        assignedGroup != null -> println("\"$name\" is assigned to to group: ${assignedGroup.name}")
        assignedUser != null -> println("\"$name\" is assigned to to user: ${assignedUser.name}")
    }
}

// End of UglyTask implementation

class Task(val name: String, val assignedTo: AssignedTo = AssignedToNoOne)

sealed class AssignedTo
object AssignedToNoOne: AssignedTo()
data class AssignedToUser(val user: User): AssignedTo()
data class AssignedToGroup(val group: Group): AssignedTo()


fun Task.printAssignment() {
    when (assignedTo) {
	  is AssignedToNoOne -> println("\"$name\" is assigned to no one")
    is AssignedToGroup -> println("\"$name\" is assigned to ${assignedTo.group.name}")
    is AssignedToUser -> println("\"$name\" is assigned to ${assignedTo.user.name}")	
    }
}

fun main() {
  	val tsd = User("TSD")
    val kotlinEnthusiasts = Group("kotlin enthusiasts")

    UglyTask("sent the solution").printAssignment()
    UglyTask("implement data class", assignedUser = tsd).printAssignment()
    UglyTask("implement sealed class", assignedGroup = kotlinEnthusiasts).printAssignment()
    
    Task("sent the solution", AssignedToNoOne).printAssignment()
    Task("implement data class", AssignedToUser(tsd)).printAssignment()
    Task("implement sealed class", AssignedToGroup(kotlinEnthusiasts)).printAssignment()
}
