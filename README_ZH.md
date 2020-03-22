﻿# MGS-Machinery
- [English Manual](./README.md)
- [阿里云](https://www.aliyun.com/minisite/goods?userCode=0fgf4qk9)

## 概述
- Unity绑定机械关节，铰链，机构插件包。

## 需求
- 绑定曲柄，即旋转关节，例如：起重机的上车部分以及大臂部分，外啮合齿轮，内啮合齿轮等。
- 绑定伸缩滑块，例如：起重机的伸缩力臂和横向/纵向支腿，压路机的腰部铰接等。
- 绑定液压油缸，例如：挖掘机的力臂驱动油缸，平地机的刮刀偏移驱动油缸等。
- 绑定曲柄摇杆机构，即平面四杆铰链，例如：装载机的铲斗，挖掘机的挖斗等。
- 绑定曲柄滑块机构，例如：往复活塞式内燃机，飞机行星发动机等。
- 绑定完整的工程机械，例如：起重机，压路机，装载机，平地机，挖掘机等。
- 绑定啮合齿轮传动机构。
- 绑定蜗轮蜗杆传动机构。
- 绑定皮带飞轮传动机构。
- 绑定差速器传动机构。
- 绑定变速器传动机构。
- 绑定振荡器。

## 环境
- Unity 5.0 或更高版本。
- .Net Framework 3.0 或更高版本。

## 实现
- Mechanism：机械关节，铰链，机构抽象定义。
- FreeCrank：自由曲柄，绕Z轴自由旋转。
- GearCrank：自由曲柄，绕Z轴自由旋转，可以线速度驱动。
- LimitCrank：受限曲柄，绕Z轴在指定角度范围内旋转。
- CrankRocker：曲柄摇杆机构。
- CrankSlider：曲柄滑块机构。
- RockerHinge：摇杆铰链，随摇杆摆动而旋转(单轴向)。
- RockerJoint：摇杆关节，始终朝向目标关节。
- RockerLimiter：摇杆限位器，限定一对摇杆之间的距离范围。
- RockerRivet：摇杆铆钉，始终与目标关节位置（世界坐标）相同。
- RockerSpring：摇杆弹簧，动态弹簧始终朝向目标关节。
- Slider ：伸缩滑块关节。
- SliderArm：序列伸缩臂。
- Synchronizer：同步器，统一线速度驱动同步器的所有机构。
- Transmission：变速器，按指定比例线速度驱动变速器的相应机构，用于协调多个机构的运转。
- MechanismDriver：通用机构驱动器。
- Gear：齿轮，绕Z轴向作圆周运动。
- Axle：转轴，绕Z轴向作圆周运动。
- CoaxialGear ：共轴轮，与另一个齿轮共轴，只输出转速，不转动。
- WormGear：绑定蜗轮。
- WormShaft：绑定蜗杆。
- Belt：传送带，UV沿X方向移动模拟运转。
- LinearVibrator：线性振动器，沿Z轴向作往复运动。
- CentrifugalVibrator：离心振动器，绕Z轴向作离心运动。
- Motor：马达，提供动力驱动转轴。
- Differential：普通差速器。

## 案例
- “MGS-Machinery/Prefabs”目录下存有上述机械关节和完整机械绑定的预制，供读者参考。
- “MGS-Machinery/Scenes”目录下存有上述机械关节和完整机械绑定的演示案例，供读者参考。

## 预览
- Crank Rocker

![Crank Rocker](./Attachment/README_Image/CrankRocker.gif)

- Crank Slider

![Crank Slider](./Attachment/README_Image/CrankSlider.gif)

- Rocker Spring

![Rocker Spring](./Attachment/README_Image/RockerSpring.gif)

- Extend Mould

![Extend Mould](./Attachment/README_Image/ExtendMould.gif)

- Cross Extender

![Cross Extender](./Attachment/README_Image/CrossExtender.gif)

- Rocker Hinge

![Rocker Hinge](./Attachment/README_Image/RockerHinge.gif)

- Internal Gearing

![Internal Gearing](./Attachment/README_Image/InternalGearing.gif)

- Airplane Engine

![Airplane Engine](./Attachment/README_Image/AirplaneEngine.gif)

- Gas Engine

![Gas Engine](./Attachment/README_Image/GasEngine.gif)

- Crane

![Crane](./Attachment/README_Image/Crane.gif)

- Road Roller

![Road Roller](./Attachment/README_Image/RoadRoller.gif)

- Loader

![Loader](./Attachment/README_Image/Loader.gif)

- Grader

![Grader](./Attachment/README_Image/Grader.gif)

- Excavator

![Excavator](./Attachment/README_Image/Excavator.gif)

- Dumper

![Dumper](./Attachment/README_Image/Dumper_H.gif)

- Dumper

![Dumper](./Attachment/README_Image/Dumper_P.gif)

- Helicopter

![Helicopter](./Attachment/README_Image/Helicopter.gif)

- Mesh Gears

![Mesh Gears](./Attachment/README_Image/MeshGears_E.gif)

- Mesh Gears

![Mesh Gears](./Attachment/README_Image/MeshGears_C.gif)

- Belt

![Belt](./Attachment/README_Image/Belt.gif)

- Worm Gear

![Worm Gear](./Attachment/README_Image/WormGear.gif)

- Vibrosieve

![Vibrosieve](./Attachment/README_Image/Vibrosieve.gif)

- Differential

![Differential](./Attachment/README_Image/Differential.gif)

- Transmission

![Transmission](./Attachment/README_Image/Transmission.gif)

## 联系
- 如果你有任何问题或者建议，欢迎通过mogoson@outlook.com联系我。