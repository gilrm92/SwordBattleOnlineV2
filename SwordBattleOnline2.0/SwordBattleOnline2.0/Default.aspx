<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SwordBattleOnline.Site.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="js/Default.js"></script>
    <div id="topo">
    	    <div id="logo">
	            <h2>Sword Battle Online</h2>	
            </div>
    	    <br />
    	    <center></center>
		    <div id="login">
        	    <form method="post">
                    <table cellpadding="2">
                        <tr>
                            <td>Login:</td>
                            <td><input type="text" name="login" class="text_login"/></td><td>&nbsp;</td>
                        </tr>
                    
                        <tr>
                            <td>Senha:</td>
                            <td><input type="password" name="senha" class="text_login"/></td>
                            <td>
                               <input type="submit" value="Ok" class="botaologin"/>
                            </td>
                        </tr>
                    </table>
                </form>
            </div>
	    </div>
	    <div id="conteudo" align="center">
		
			    <h3>Sword Battle Online</h3>
			    <br><br>
			    Um mundo onde você pode viver e experimentar o calor de uma batalha. 
			    <br>
			    Nesse jogo você só terá <b>uma</b> chance de mostrar seu potencial e chegar ao ultimo andar dessa aventura.
			    <br>
			    "Um mundo de sonhos, é onde podemos esquecer da vida real e seus problemas, e viver o que quisermos."
		
		
		<br /><br />
        <table>
            <tr>
                <td align="center">
                    <h4>Registre-se agora!</h4>
                </td>
            </tr>
            <tr>
                <td><input type="text" id="txtNome" maxlength="100" placeholder="Digite seu nome..." /></td>
            </tr>
            <tr>
                <td><input type="text" id="txtEmail" maxlength="100" placeholder="Digite seu e-mail..." /></td>
            </tr>
            <tr>
                <td><input type="text" id="txtRepetirEmail" maxlength="100" placeholder="Repita seu e-mail..."/></td>
            </tr>
            <tr>
                <td><input type="password" id="txtSenha" maxlength="100" placeholder="Digite sua senha..." /></td>
            </tr>
            <tr>
                <td><input type="password" id="txtRepetirSenha" maxlength="100" placeholder="Repita sua senha também..." /></td>
            </tr>
            <tr>
                <td align="center">
                    <input type="button" id="btnCadastrar" value="Cadastre-me AGORA!" />
                </td>
            </tr>
        </table>
	    </div>
        
</asp:Content>