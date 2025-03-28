﻿using Gerenciador_Tarefas.Communication.Enums;

namespace Gerenciador_Tarefas.Communication.Responses;
public class ResponseUpdatedTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public Priority Priority { get; set; }
}
