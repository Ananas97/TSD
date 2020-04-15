# task 1 + task 2
class Integer
  def factorial
    if (self < 0)
      raise 'Runtime error: cannot count factorial for negative number'
    end

    (1..self).inject(:*)
  end
end

puts(1.factorial) # 1
puts(3.factorial) # 6
puts(-1.factorial)

# task 3
module InstanceModule
  def square(n)
    n**2
  end
end

class Integer
  extend InstanceModule
end

puts(Integer.square(4))

# task 4
module ClassModule
  def sample(size)
    if (size < 0)
      raise ArgumentError, 'ArgumentError: the number must be positive'
    end

    nums = []
    size.times do
      nums.push(rand(1..900))
    end
    puts "#{nums}"
  end
end

class Integer
  extend ClassModule
end

puts(Integer.sample(4))
puts(Integer.sample(-1))