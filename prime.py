primes = [3]
for i in range (5, 10000, 2):
    result = True
    for t in primes:
        if i%t == 0:
            result = False
            break
    if result:
        primes.append(i)
primes.insert(0, 1)
primes.insert(1, 2)
print(primes)
