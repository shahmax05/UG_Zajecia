def powiedz(imie="Ciebie"):
    if imie == "Ciebie":
        odmienione = imie
    elif imie.endswith("a"):
        odmienione = imie[:-1] + "y"
    else:
        odmienione = imie + "a"
        
    return f"Jedno dla {odmienione}, jedno dla mnie."

print(powiedz("Justyna"))
print(powiedz("Piotr"))
print(powiedz())