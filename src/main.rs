fn convert(s: String, num_rows: i32) -> String {

    let rows: u8 = num_rows;
    let boxed: Box<u8> = Box::new(rows);
    let mut arr = vec!["", num_rows];

    let len = s.len();
    let mut count = 0;
    let mut r=0;
    let mut bevel = false;

    while count<len {
        arr[r]+=s.chars().nth(count);
        count+=1;
        if count==len{
            break;
        }

        if !bevel && r<num_rows{
            r+=1;
        }

        if r==num_rows{
            bevel = true;
            r-=1;
        }

        if bevel && r>0 {
            r-=1;
        }

        if r==0{
            bevel = false;
        }
    }

    let mut res = "";
    for i in 0..num_rows{
        res += arr[i];
    }
    return res.to_string();
}


fn main() {
    println!("Hello world!");
    let str = "PAYPALISHIRING".to_string();
    let res = convert(str, 3);
    println!("{}", res);
}