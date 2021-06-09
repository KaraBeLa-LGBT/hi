using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    LineRenderer _lineRend;
    public float lenght_laser;
    private void Start()
    {
        _lineRend = GetComponent<LineRenderer>();
    }

    private void Update()
    {

        // создаём луч из центра спрайта в направлении его локальной оси "вправо"
        Ray2D ray = new Ray2D(transform.position, transform.right);
        // пускаем луч, для проверки на пересечения с 2д коллайдерами
        RaycastHit2D hit2D = Physics2D.Raycast(ray.origin, ray.direction, lenght_laser);
        // устанавливаете первую точку лайнРендера в позицию спрайта
        _lineRend.SetPosition(0, ray.origin);
        // если было столкновение, то устанавливает вторую точку лайнРендера в месте столкновения
        if (hit2D.collider != null) { _lineRend.SetPosition(1, hit2D.point);
            Debug.Log("ssss");
        }
        // если столкновения не было, то устанавливаем вторую точку лайнРендера на расстоянии в lenght_laser от начальной точки
        else _lineRend.SetPosition(1, ray.origin + ray.direction * lenght_laser);
    }
}
