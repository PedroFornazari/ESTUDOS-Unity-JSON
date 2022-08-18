using System.Runtime.Serialization;

[DataContract]
public class Local
{
    [DataMember]
    public float posx;
    [DataMember]
    public float posy;
    [DataMember]
    public float posz;
    [DataMember]
    public float rotx;
    [DataMember]
    public float roty;
    [DataMember]
    public float rotz;

}

