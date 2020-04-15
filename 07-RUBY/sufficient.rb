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
