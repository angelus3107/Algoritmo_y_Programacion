
package main
import "fmt"

func main() {

  var num int
  fmt.Println("ingrese el numero.")
  
  fmt.Scanln(&num)
  
  if num%2 == 0 {
    fmt.Println("es par")
  }else{
    fmt.Println("es impar")
  }
}
