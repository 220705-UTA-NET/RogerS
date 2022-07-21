namespace RogerAtm{
    class Helper
    {
        public static void calculate(int int1, int int2){
            int ans = 0;

            for(int i = int2; i > 0; i--){
                ans += i * int1;
            }
            
            Console.WriteLine(ans);
        }
        public static void read(int int1, int int2){
            int ans = 0;

            for(int i = int2; i > 0; i--){
                ans += i * int1;
            }
            
            Console.WriteLine(ans);
        }
    
        public static void delete(){
            int ans = 0;
            Console.WriteLine(ans);
        }
    }
}