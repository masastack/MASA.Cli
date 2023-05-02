# MASA.Cli





## 使用

### 创建 Cqrs 实体模板

```shell
masa create-entity Todo -mode cqrs
```

该命令会自动寻找当前目录下的sln文件名称，并作为项目名称，按照masa的cqrs模板创建单个实体所需的所有cqrs类。如下图所示

![image](https://user-images.githubusercontent.com/38368335/235729583-bd3deaa4-5d18-4ecb-ac07-4edc69fe49ee.png)



## 模板参数说明

`masa Action Target --params`

### Action参数

* `new`：创建 masa 模板项目，该功能未实现
* create-entity：创建实体模板

### Target 参数

目标值：可能是项目名称，也可能是实体类名称。例如：创建实体：`masa create-entity Todo -mode cqrs`



### Params 参数

Action命令参数，一般有以下几种

* new命令
* create-entity 命令
  * -model： 创建实体所使用的模式
    1. cqrs：使用cqrs的模式
    2. ddd：使用ddd的模式
  * -project-name：项目名称（可选值，如果不传入则会自动寻找运行命令目录下的sln文件名称作为项目名称）