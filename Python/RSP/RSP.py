import random

def Convert(x) :
    if x == 1 :
        y = "グー"
    elif x == 2 :
        y = "パー"
    else :
        y ="チョキ"
    return y

input = input("出す手をカタカナで入力してください : ")

if input != "グー" and input != "パー" and input != "チョキ" :
    print("その手は存在しません")
    print("反則なので私の勝ちです")

else :
    cpu_val = random.randint(1,3)# 1 は グー, 2 は パー, 3 は チョキ

    if input == "グー" :
        player_val = 1
    elif input == "パー" :
        player_val = 2
    else :
        player_val = 3

    print("あなたの出した手  :  " + input)
    print("私の出した手  :  " + Convert(cpu_val))


    if (player_val - cpu_val) % 3 == 1 :
        print("おめでとうございます!あなたの勝ちです!")
    elif player_val == cpu_val :
        print("あいこです、実質私の勝ちですね")
    else :
        print("私の勝ちです、出直してきて下さい")
