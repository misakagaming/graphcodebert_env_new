import com.j2cg.base.CTCoolGenCore;

public class CYY1S081_TRAIN014 extends CTCoolGenCore {

protected iyy1_component m_LocalEntity001;
protected dont_change_return_codes m_LocalEntity002;
protected group_context m_LocalEntity003;

@Override
public void initialize(Object... inputs) {
}

@Override
public void execute(Object...outputs) {

switch (m_LocalEntity001.send_command)
{
case "MOVE":
m_LocalEntity003.setSubscript(3);
break;

case "FAIL":
m_LocalEntity001.return_code = m_LocalEntity002.n1110_unauthorized_operation;
break;
}
}

}