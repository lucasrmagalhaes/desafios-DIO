option = 0
alcohol = 0
fuel = 0
diesel = 0

while option != 4
	option = gets.strip.to_i
	
	case option
	when 1 then alcohol += 1
	when 2 then fuel += 1
  when 3 then diesel += 1
  when 4 then puts "MUITO OBRIGADO"
	end
end

puts "Alcool: #{alcohol}"
puts "Gasolina: #{fuel}"
puts "Diesel: #{diesel}"