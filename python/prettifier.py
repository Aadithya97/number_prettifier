def prettify_number(number):
    if number < 1_000_000:
        return str(number)
    elif number < 1_000_000_000:
        pretty_number = round(number / 1_000_000, 1)
        return f"{pretty_number:g}M"
    elif number < 1_000_000_000_000:
        pretty_number = round(number / 1_000_000_000, 1)
        return f"{pretty_number:g}B"
    else:
        pretty_number = round(number / 1_000_000_000_000, 1)
        return f"{pretty_number:g}T"


if __name__ == "__main__":
    print(prettify_number(1000000))         # 1M
    print(prettify_number(2500000.34))      # 2.5M
    print(prettify_number(532))             # 532
    print(prettify_number(1123456789))      # 1.1B
    print(prettify_number(1000000000000))   # 1T
    
    
# Without Math Libraries:
# 
# def prettify_number(number):
#     sign = "-" if number < 0 else ""
#     number = abs(number)
    
#     if number < 1_000_000:
#         return f"{sign}{number}"
#     elif number < 1_000_000_000:
#         pretty_number = int(number / 1_000_000 * 10) / 10.0
#         return f"{sign}{pretty_number:g}M"
#     elif number < 1_000_000_000_000:
#         pretty_number = int(number / 1_000_000_000 * 10) / 10.0
#         return f"{sign}{pretty_number:g}B"
#     else:
#         pretty_number = int(number / 1_000_000_000_000 * 10) / 10.0
#         return f"{sign}{pretty_number:g}T"


