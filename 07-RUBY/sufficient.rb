# task 1
class Integer
  def factorial
    (1..self).inject(:*)
  end
end

puts(1.factorial) # 1
puts(3.factorial) # 6

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
      raise ArgumentError
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
