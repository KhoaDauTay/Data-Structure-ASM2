class Queue:

    def __init__(self, max):
        if max <= 250:
            self.max = max # kích thước tối đa < 250
        else:
            self.max = 250
        self.Q = [] # mảng chứa phần tử
        self.f = 0
        self.r = 0

    def numcout(self):
        return ((self.max - self.f) + self.r) % self.max

    def enqueue(self, x): # them X vao rear cua queue
        if self.numcout() == (self.max - 1):
            print("Queue is full")
        else:
            self.Q.append(x) # them vao cuoi hang doi
            self.r = (self.r + 1)% self.max
    def dequeue(self):
        char = ''
        if self.numcout() == 0:
            print("Queue is Empty")
        else:
            char = self.Q[self.f] # Lay pt tai front
            self.f = (self.f + 1)% self.max
        return char
    
    def transfer(self, s1):
        s2 = ""
        i = 0
        count = 0
        if len(s1) == 0:
            print("The string is emty!!!")
            return "";
        elif(len(s1)>255):
            print("Max char lon hon 255. Please re-enter")
            return ""
        else:
            try:
                # Khoi Try catch p5
                while i < len(s1): # Chuyển lần lượt các ký tự vào Q
                    while self.numcout() < (self.max -1): # Q chưa đầy thì đẩy các kí tự vào Q
                        char = s1[i]  # lấy 1 kí tự thứ i đưa vào Q
                        self.enqueue(char)
                        i +=1
                        if (i >= len(s1)): # Da lay het cac ky tu trong s1
                            break
                    while self.numcout() > 0:
                        char = self.dequeue()
                        s2 = s2 + char # Chuyển s1 kí tự Q và S2
                    count = count + 1 # Dem so lan su dung bo dem Q
                # Sau khi hết s1 nhưung con trống Q
                while self.numcout() > 0: # Q chứa rỗng
                    char = dequeue()
                    s2 = s2 + char # Chuyển kí tự Q và S2
                print(" Số lần sử dụng Buffer Q" +' '+str(count))
                return s2
            except BaseException as be:
                print('[Error]'+str(be))
                return ""

print('Nhap chuoi can chuyen: s1= ""')
s1 = input()
q = Queue(len(s1))
s2= q.transfer(s1)
print("Chuoi dan den s2 noi dung nhu sau:")
print(s2)
