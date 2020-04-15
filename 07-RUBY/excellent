
class Clock

  attr_reader :hours, :minutes, :seconds

  def initialize(hours, minutes, seconds)
    @clock_hours = hours
    @clock_minutes = minutes
    @clock_seconds = seconds
  end

  def print
    puts "The current time is #{@clock_hours}:#{@clock_minutes}:#{@clock_seconds}"
  end

  def +(number)
    altered_hours = (@clock_hours + ((@clock_minutes + number) / 60)) % 24
    altered_minutes = (@clock_minutes + number + (@clock_seconds + number) / 60) % 60
    altered_seconds = (@clock_seconds + number) % 60
    Clock.new(altered_hours, altered_minutes, altered_seconds)
  end

  def -(number)
    altered_hours = (@clock_hours + ((@clock_minutes + number) / 60)) % 24
    altered_minutes = (@clock_minutes - number -  (@clock_seconds + number) / 60) % 60
    altered_seconds = (@clock_seconds - number) % 60
    Clock.new(altered_hours, altered_minutes, altered_seconds)
  end

  def ==(different_clock)
    if !(@clock_hours == different_clock.hours and
        @clock_minutes == different_clock.minutes and
        @clock_seconds == different_clock.seconds)
      return false
    else return true
    end
  end
end

clock = Clock.new(10, 0, 0)
clock.print  # The current time is 10:00:00
clock += 30
clock.print  # The current time is 10:30:00
puts(clock == Clock.new(10, 30, 0)) # true
