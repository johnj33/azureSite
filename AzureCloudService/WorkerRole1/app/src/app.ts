import {bindable} from "aurelia-framework";
import {PageState} from "pageState";

export class App {
    message: string = 'Page Number: ';
    public pageState: PageState = new PageState();

}
