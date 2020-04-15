# task 4
def pangram?(word)
  puts((('A' .. 'Z')).all? { |char| word.upcase.include? (char) })
end

pangram?("abba") # false
pangram?("The quick brown fox jumps over the lazy dog.") # true

#task 2
def decimal(binary_string)
  if(!(binary_string.chars.all? {|x| x =~ /[01]/}))
  raise 'ArgumentError: this is not a binary number'
  end

  puts(binary_string.to_i(2))
end
decimal("101") # 5
