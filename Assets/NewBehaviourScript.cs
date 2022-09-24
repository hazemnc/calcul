using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
      public int a,b,result;
      public void Start(){
      sum();
      prod();
      divi();
      }
    public void sum(){
        result=a+b;
        debug.log(result);
    } 
    public void prod(){
        result=a*b;
        debug.log(result);
    }
    public void divi(){
        if(b==0){
            debug.log("erreur");}
            else{
                result= a / b;
                debug.log(result);
            }
        }
        
}
