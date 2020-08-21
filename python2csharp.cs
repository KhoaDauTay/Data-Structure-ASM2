namespace Namespace {
    
    using System.Collections.Generic;
    
    public static class Module {
        
        public class Queue {
            
            public Queue(object max) {
                if (max <= 250) {
                    this.max = max;
                } else {
                    this.max = 250;
                }
                this.Q = new List<object>();
                this.f = 0;
                this.r = 0;
            }
            
            public virtual object numcout() {
                return (this.max - this.f + this.r) % this.max;
            }
            
            public virtual object enqueue(object x) {
                // them X vao rear cua queue
                if (this.numcout() == this.max - 1) {
                    Console.WriteLine("Queue is full");
                } else {
                    this.Q.append(x);
                    this.r = (this.r + 1) % this.max;
                }
            }
            
            public virtual object dequeue() {
                var char = "";
                if (this.numcout() == 0) {
                    Console.WriteLine("Queue is Empty");
                } else {
                    char = this.Q[this.f];
                    this.f = (this.f + 1) % this.max;
                }
                return char;
            }
            
            public virtual object transfer(object s1) {
                object char;
                var s2 = "";
                var i = 0;
                var count = 0;
                if (s1.Count == 0) {
                    Console.WriteLine("The string is emty!!!");
                    return "";
                } else if (s1.Count > 255) {
                    Console.WriteLine("Max char lon hon 255. Please re-enter");
                    return "";
                } else {
                    try {
                        // Khoi Try catch p5
                        while (i < s1.Count) {
                            // Chuyển lần lượt các ký tự vào Q
                            while (this.numcout() < this.max - 1) {
                                // Q chưa đầy thì đẩy các kí tự vào Q
                                char = s1[i];
                                this.enqueue(char);
                                i += 1;
                                if (i >= s1.Count) {
                                    // Da lay het cac ky tu trong s1
                                    break;
                                }
                            }
                            while (this.numcout() > 0) {
                                char = this.dequeue();
                                s2 = s2 + char;
                            }
                            count = count + 1;
                        }
                        // Sau khi hết s1 nhưung con trống Q
                        while (this.numcout() > 0) {
                            // Q chứa rỗng
                            char = dequeue();
                            s2 = s2 + char;
                        }
                        Console.WriteLine(" Số lần sử dụng Buffer Q" + " " + count.ToString());
                        return s2;
                    } catch (BaseException) {
                        Console.WriteLine("[Error]" + be.ToString());
                        return "";
                    }
                }
            }
        }
        
        public static object s1 = input();
        
        public static object q = Queue(s1.Count);
        
        public static object s2 = q.transfer(s1);
    }
}
