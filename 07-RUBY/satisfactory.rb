# task 4
def pangram?(word)
  puts((('A' .. 'Z')).all? { |char| word.upcase.include? (char) })
end

pangram?("abba") # false
pangram?("The quick brown fox jumps over the lazy dog.") # true
