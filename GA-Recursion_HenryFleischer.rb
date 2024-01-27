#Count up to 10, and print every number as it's counted to
def PrintNumbersFrom1To10(baseCase)
    if baseCase < 10
    print (baseCase + 1).to_s + ", "
    PrintNumbersFrom1To10(baseCase + 1)
    end
end
print "\n"
puts "Counting up to 10"
PrintNumbersFrom1To10(0)


#Count down to zero, then back to 25, and print all numbers counted to
def CountDownAndUp baseCase
    if baseCase > 0
    print (baseCase).to_s + ", "
    CountDownAndUp(baseCase - 1)
        print (baseCase).to_s + ", "
    end
end
print "\n"
puts "Counting down to zero, then up to 25"
CountDownAndUp 25

# Sum all numbers in an Array
#For time's sake, I'm going to assume the array only has numbers in it!
numbers = [2,4,8,16,2] #=32

def sum(array, index)
val = array[index]
    if index > array.count - 1
        return 0
    end
    # puts array[index]
    return val + sum(array, index + 1)

end
print "\n"
puts "Summing " + numbers.to_s()
puts "Sum is " + sum(numbers,0).to_s

#Fibbinachi Sequence
#Each number is the sum of the two previous numbers
def Fibbinachi num1, num2, iteration
    if iteration < 10
    print num1 + num2
    print ", "
    Fibbinachi num2, num1 + num2, iteration + 1
    end
end
puts "Printing Fibbinachi sequence"
print "0, 1, "
Fibbinachi(0,1,0)
