# 360View_VR
--------------------------
## Description
코로나 19로 인해 여행을 자주 하기 힘들고 이로 인해 여행을 간접적으로 하고 싶어하는 사람들이 늘고 있는 상황이다. 
그래서 여행을 간접적으로 경험하고 싶어하는 많은 사람들을 위해 조금 더 생동감있고 현실적인 간접 여행을 위해 VR과 360도 영상을 활용한 컨텐츠를 제작하게 되었다.
--------------------------
## Environment
  * Unity 2019.3.16 버전
-------------------------
## Prerequisite
  * Shader 파일
    * 화면에 출력할 때, 화면에 출력할 픽셀의 위치나 색상을 계산해주는 역할
    * 해당 파일을 이용해서 내부에 360도 영상을 보여주는 것이 가능
  * NameSpace
```
using UnityEngine;
using UnityEngine.UI;
```
-----------------------------
## Usage
  * 사용자 카메라를 구체 안에 넣어주고, Shader 파일을 해당 구체에 넣어주기
  * 해당 구체 안에 원하는 360도 영상을 삽입
  * 사용자 카메라에 Raycast 스크립트를 넣어주어 원하는 상호작용이 가능하도록 세팅
-------------------------------
## Code
  * Raycast
    * 가상의 광선을 이용해서 시선 등으로 메뉴 선택 등의 동작이 가능
    ```
    void raycasting(){
        RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward *1000);
        if(Physics.Raycast(transform.position, forward, out hit)){
            timegone = timegone + Time.deltaTime;
            gauge.fillAmount = timegone / 3;
            if(timegone >= 3){
                hit.transform.GetComponent<Button>().onClick.Invoke();
            }
        }else{
            timegone = 0;
            gauge.fillAmount = timegone / 3;
        }
        Debug.DrawRay(transform.position, forward, Color.blue);
    }
    ```
-----------------------------
## Example
  * 시작 화면
  * 360 영상
