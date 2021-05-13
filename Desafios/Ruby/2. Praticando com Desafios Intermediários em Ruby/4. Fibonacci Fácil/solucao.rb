n = gets.strip.to_i

resultado = ""
soma = 0
ant = 0
prox = 1

0.upto(n-1) do |num|
  
	if num == 0 || num == 1
		resultado << num.to_s << " "
	else
		soma = ant + prox
		ant = prox
		prox = soma
		resultado << soma.to_s << " "
	end
	
end

puts resultado.strip