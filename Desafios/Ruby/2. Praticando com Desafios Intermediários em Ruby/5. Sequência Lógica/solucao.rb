number_times = gets.strip.to_i

1.upto(number_times) do |number|
	puts "#{number} #{number ** 2} #{number ** 3}"
	puts "#{number} #{number ** 2 + 1} #{number ** 3 + 1}"
end