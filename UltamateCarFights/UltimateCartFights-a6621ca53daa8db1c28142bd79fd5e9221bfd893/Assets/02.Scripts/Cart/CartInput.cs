using UnityEngine;
using UnityEngine.InputSystem;

namespace UltimateCartFight.Game
{
    public class CartInput : MonoBehaviour
    {
        #region Cart Input Method
        [SerializeField] private InputAction accelaration;
        [SerializeField] private InputAction steer;
        [SerializeField] private InputAction dash;

        private Gamepad gamepad;
        private bool wasDashed;

        public InputData GetInput()
        {
            //현재 연결된 컨트롤러 정보를 가져옴
            gamepad = Gamepad.current;
            //가속 회전 입력 정보 저장
            InputData input = new InputData();
            input.Acceleration = accelaration.ReadValue<float>();
            input.Steer = steer.ReadValue<float>();

            input.IsDash = dash.IsPressed();
            input.IsDashDown = (!wasDashed) && (input.IsDash);
            wasDashed = input.IsDash;
            return input;
        }


        #endregion
        #region UnityLifeCycleMethod
        private void Awake()
        {
            accelaration = accelaration.Clone();// accel 복제
            steer = steer.Clone(); //steer 복제
            dash = dash.Clone(); //dash 복제 

            accelaration.Enable(); // 활성화
            steer.Enable();
            dash.Enable();
        }
        private void OnDestroy()
        {
            accelaration.Disable(); //비활성화
            steer.Disable();
            dash.Disable();
        }
        #endregion
    }
    public struct InputData
    {
        //가속(전/후진)
        private int _acceleration;
        public float Acceleration
        {
            get { return _acceleration * 0.001f; }
            set { _acceleration = (int)(value * 1000); }
        }
        //회전(좌/우회전)
        private int _steer;
        public float Steer
        {
            get { return _steer * 0.001f; }
            set { _steer = (int)(value * 1000); }
        }
        public bool IsDash; //대쉬키가 눌러져있는지 확인
        public bool IsDashDown; // 현재 프레임에 대쉬키가 눌려져있는지
    }
}
